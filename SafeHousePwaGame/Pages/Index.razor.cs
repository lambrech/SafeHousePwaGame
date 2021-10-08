namespace SafeHousePwaGame.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BlazorPro.BlazorSize;
    using Microsoft.AspNetCore.Components;
    using Microsoft.JSInterop;

    public partial class Index : IDisposable
    {
        // We can also capture the browser's width / height if needed. We hold the value here.
        private BrowserWindowSize browser = new();

        public Index()
        {
            this.Game = new Game();
        }

        [Inject]
        public ResizeListener Listener { get; private set; } = null!;

        [Inject]
        public IJSRuntime JsRuntime { get; private set; } = null!;

        public Game Game { get; }

        public int Size { get; set; }

        public double? DevicePixelRatio { get; set; }

        void IDisposable.Dispose()
        {
            // Always use IDisposable in your component to unsubscribe from the event.
            // Be a good citizen and leave things how you found them. 
            // This way event handlers aren't called when nobody is listening.
            this.Listener.OnResized -= this.WindowResized;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                this.DevicePixelRatio = await this.JsRuntime.InvokeAsync<double>("getWindowDevicePixelRatio");

                // Subscribe to the OnResized event. This will do work when the browser is resized.
                this.Listener.OnResized += this.WindowResized;
            }
        }

        // This method will be called when the window resizes.
        // It is ONLY called when the user stops dragging the window's edge. (It is already throttled to protect your app from perf. nightmares)
        private void WindowResized(object? _, BrowserWindowSize window)
        {
            // Get the browser's width / height
            this.browser = window;
            this.CalcSize();
        }

        private void CalcSize()
        {
            var maxPartWidth = (this.browser.Width / 8) - 8;
            var maxPartHeight = (int)((this.browser.Height / 17) - 8);

            this.Size = maxPartWidth < maxPartHeight ? maxPartWidth : maxPartHeight;
            this.StateHasChanged();
        }
    }

    public class Game
    {
        public Game()
        {
            this.ResetGame();
        }

        public bool ShowDialog { get; set; }

        public void CheckGameFinished()
        {
                //this.OpenDialog(true);
        }

        public void OpenDialog()
        {
            this.ShowDialog = true;
        }

        public void CloseDialog()
        {
            this.ShowDialog = false;
        }

        public List<Joker> Jokers { get; set; } = new ();

        public ChallengeField? FocusedChallengeField { get; private set; }

        public void FocusChallengeField(ChallengeField? challengeField)
        {
            this.FocusedChallengeField?.ClearIfChallengeNotValid();
            this.FocusedChallengeField = challengeField;
        }

        public void HandleInput(InputButton btn)
        {
            btn.HandleInput(this.FocusedChallengeField,
                () =>
                {
                    if (this.FocusedChallengeField == null)
                    {
                        return;
                    }

                    // check if valid - otherwise clear focused field
                    this.FocusedChallengeField?.ClearIfChallengeNotValid();

                    // if valid recalc position of player --> this is done implicitly because player position is a calculated property

                    this.FocusedChallengeField = null;
                });
        }

        public List<int> GamePositions { get; private set; } = new();

        public List<List<int>> GamePositionRows => this.CalcGamePositionRows();

        private List<List<int>> CalcGamePositionRows()
        {
            if (this.GamePositions.Count != 40)
            {
                return new List<List<int>>();
            }

            var list = new List<List<int>>();

            for (int i = 0; i < this.GamePositions.Count; i = i+8)
            {
                list.Add(this.GamePositions.Skip(i).Take(8).ToList());
            }

            return list;
        }

        public int KillerPosition { get; private set; } = 0;

        public void IncreaseKillerPosition()
        {
            this.KillerPosition += 1;
        }

        public void DecreaseKillerPosition()
        {
            if (this.KillerPosition <= 0)
            {
                this.KillerPosition = 0;
                return;
            }

            this.KillerPosition -= 1;
        }

        public int PlayerPosition => this.CalcPlayerPosition();

        private int CalcPlayerPosition()
        {
            return 16 + this.Challenges.Where(x => x.IsCompleted).Sum(x => x.Score);
        }

        public List<InputButton> InputButtons { get; private set; } = new();

        public List<List<InputButton>> InputButtonRows => this.CalcInputButtonRows();

        private List<List<InputButton>> CalcInputButtonRows()
        {
            if (this.InputButtons.Count != 12)
            {
                return new List<List<InputButton>>();
            }

            var list = new List<List<InputButton>>();

            for (int i = 0; i < this.InputButtons.Count; i = i + 6)
            {
                list.Add(this.InputButtons.Skip(i).Take(6).ToList());
            }

            return list;
        }

        public void ChangeGameMode(GameMode gameMode)
        {
            this.GameMode = gameMode;
        }

        public void ResetGame()
        {
            this.Challenges = this.GameMode.CreateChallenges();
            this.GamePositions = new List<int>();
            for (var i = 0; i < 40; i++)
            {
                this.GamePositions.Add(i + 1);
            }

            this.InputButtons = new List<InputButton>();
            for (var i = 0; i < 12; i++)
            {
                this.InputButtons.Add(new InputButton(i));
            }

            this.Jokers = new[] { new Joker("No K"), new Joker("RR"), new Joker("Col1"), new Joker("Col2"), new Joker("Col3") }.ToList();
            this.KillerPosition = 0;
        }

        public GameMode GameMode { get; set; }

        public List<GameMode> AvailableGameModes { get; } = Enum.GetValues(typeof(GameMode)).Cast<GameMode>().ToList();

        public List<Challenge> Challenges { get; set; } = new ();

        public string CalcGamePositionColor(int gamePosition)
        {
            if (gamePosition <= this.KillerPosition)
            {
                return ChallengeFieldColor.Red.ToDisplayColor();
            }

            if (gamePosition <= this.PlayerPosition)
            {
                return ChallengeFieldColor.Yellow.ToDisplayColor();
            }

            return "lightgrey";
        }
    }

    public class Joker
    {
        public string Name { get; }

        public bool IsUsed { get; private set; }

        public Joker(string name)
        {
            this.Name = name;
        }

        public void ToggleUsed()
        {
            this.IsUsed = !this.IsUsed;
        }
    }

    public class InputButton
    {
        public InputButton(int number)
        {
            this.DisplayText = number.ToString();

            if (number == 10)
            {
                this.DisplayText = "OK";
                this.IsApplyInputButton = true;
            }

            else if (number == 11)
            {
                this.DisplayText = "RM";
                this.IsClearInputButton = true;
            }
        }

        public string DisplayText { get; set; }

        public bool IsClearInputButton { get; }

        public bool IsApplyInputButton { get; }

        public void HandleInput(ChallengeField? challengeField, Action clearFocusAction)
        {
            if (challengeField == null)
            {
                return;
            }

            if (this.IsClearInputButton)
            {
                challengeField.Clear();
                return;
            }

            if (this.IsApplyInputButton)
            {
                clearFocusAction();
                return;
            }

            var currentText = challengeField.Number?.ToString() ?? "0";
            currentText += this.DisplayText;

            if (currentText.Length > 2)
            {
                currentText = currentText.Skip(1).ToString();
            }

            if (int.TryParse(currentText, out var newNumber))
            {
                challengeField.Number = newNumber;
            }
        }
    }

    public enum GameMode
    {
        S,
        A,
        F,
        E,
    }

    public abstract record ChallengeFieldTemplate(NumberComparer NumberComparer)
    {
        public abstract ChallengeField ToChallengeField(Challenge correspondingChallenge);
    }

    public record FixedChallengeFieldTemplate(int Number, NumberComparer NumberComparer) : ChallengeFieldTemplate(NumberComparer)
    {
        public override ChallengeField ToChallengeField(Challenge correspondingChallenge)
        {
            return new ChallengeField(correspondingChallenge, this.NumberComparer, this.Number);
        }
    }

    public record EditableChallengeFieldTemplate(ChallengeFieldColor Color, NumberComparer NumberComparer) : ChallengeFieldTemplate(NumberComparer)
    {
        public override ChallengeField ToChallengeField(Challenge correspondingChallenge)
        {
            return new ChallengeField(correspondingChallenge, this.NumberComparer, this.Color);
        }
    }

    public class Challenge
    {
        public Challenge(int score, List<ChallengeFieldTemplate> challengeFields)
        {
            this.Score = score;
            this.ChallengeFields = challengeFields.Select(x => x.ToChallengeField(this)).ToList();
        }

        public int Score { get; }

        public List<ChallengeField> ChallengeFields { get; }

        public bool IsCompleted => this.CalcChallengeCompleted();

        private bool CalcChallengeCompleted()
        {
            return this.ChallengeFields.All(x => x.Number.HasValue) && this.IsValid();
        }

        public bool IsValid()
        {
            return this.ChallengeFields.All(x => x.IsValid());
        }

        public ChallengeField? FindNextEligibleField(ChallengeField referenceField)
        {
            var indexOfRef = this.ChallengeFields.IndexOf(referenceField);
            if (indexOfRef < 0 || this.ChallengeFields.Last() == referenceField)
            {
                return null;
            }

            var next = this.ChallengeFields[indexOfRef + 1];
            if (next.Number.HasValue)
            {
                return next;
            }

            if (next.NumberComparer == referenceField.NumberComparer)
            {
                return this.FindNextEligibleField(next);
            }

            return null;
        }
    }

    public class ChallengeField
    {
        public ChallengeField(Challenge correspondingChallenge, NumberComparer numberComparer, ChallengeFieldColor color)
        {
            this.CorrespondingChallenge = correspondingChallenge;
            this.NumberComparer = numberComparer;
            this.Color = color;
        }

        public ChallengeField(Challenge correspondingChallenge, NumberComparer numberComparer, int fixedNumber)
        {
            this.CorrespondingChallenge = correspondingChallenge;
            this.NumberComparer = numberComparer;
            this.Number = fixedNumber;
            this.Color = ChallengeFieldColor.Gray;
            this.IsEditable = false;
        }


        public Challenge CorrespondingChallenge { get; }

        public NumberComparer NumberComparer { get; }

        public int? Number { get; set; }

        public ChallengeFieldColor Color { get; }

        public bool IsEditable { get; } = true;

        public bool IsValid()
        {
            if (this.Number.HasValue && this.CorrespondingChallenge.FindNextEligibleField(this) is { } nextField && nextField.Number.HasValue)
            {
                return Extensions.IsNumberComparisonExpressionValid(this.Number.Value, this.NumberComparer, nextField.Number.Value);
            }

            return true;
        }

        public void ClearIfChallengeNotValid()
        {
            if (!this.CorrespondingChallenge.IsValid())
            {
                this.Clear();
            }
        }

        public void Clear()
        {
            this.Number = null;
        }
    }

    public enum NumberComparer
    {
        None,
        Equal,
        Lower,
        LowerOrEqual,
    }

    public enum ChallengeFieldColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Gray,
    }

    public static class Extensions
    {
        public static string ToDisplayString(this NumberComparer comparer)
        {
            switch (comparer)
            {
                case NumberComparer.None:
                    return string.Empty;
                case NumberComparer.Equal:
                    return "=";
                case NumberComparer.Lower:
                    return "<";
                case NumberComparer.LowerOrEqual:
                    return "<=";
                default:
                    throw new ArgumentOutOfRangeException(nameof(comparer), comparer, null);
            }
        }

        public static string ToDisplayColor(this ChallengeFieldColor color)
        {
            switch (color)
            {
                case ChallengeFieldColor.Red:
                    return "#C84243";
                case ChallengeFieldColor.Green:
                    return "#5F8D42";
                case ChallengeFieldColor.Blue:
                    return "#0D7ABD";
                case ChallengeFieldColor.Yellow:
                    return "#F0D142";
                case ChallengeFieldColor.Gray:
                    return "gray";
                default:
                    throw new ArgumentOutOfRangeException(nameof(color), color, null);
            }
        }

        public static bool IsNumberComparisonExpressionValid(int num1, NumberComparer comparer, int num2)
        {
            return comparer switch
            {
                NumberComparer.None => true,
                NumberComparer.Equal => num1 == num2,
                NumberComparer.Lower => num1 < num2,
                NumberComparer.LowerOrEqual => num1 <= num2,
                _ => throw new ArgumentOutOfRangeException(nameof(comparer), comparer, null)
            };
        }
    }
}