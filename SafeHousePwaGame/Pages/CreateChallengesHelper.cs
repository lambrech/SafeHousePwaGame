namespace SafeHousePwaGame.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CreateChallengesHelper
    {
        public static List<Challenge> CreateChallenges(this GameMode gameMode)
        {
            switch (gameMode)
            {
                case GameMode.S:
                    return new List<Challenge>(
                        new[]
                        {
                            new Challenge(
                                2,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                3,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.None),
                                }.ToList()),
                        });
                case GameMode.A:
                    return new List<Challenge>(
                        new[]
                        {
                            new Challenge(
                                2,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                3,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                        });
                case GameMode.F:
                    return new List<Challenge>(
                        new[]
                        {
                            new Challenge(
                                2,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                3,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                        });
                case GameMode.E:
                    return new List<Challenge>(
                        new[]
                        {
                            new Challenge(
                                2,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.Equal),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                3,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.Lower),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                4,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.None),
                                }.ToList()),
                            new Challenge(
                                6,
                                new[]
                                {
                                    (ChallengeFieldTemplate)new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Blue, NumberComparer.LowerOrEqual),
                                    new FixedChallengeFieldTemplate(6, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Red, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Yellow, NumberComparer.LowerOrEqual),
                                    new EditableChallengeFieldTemplate(ChallengeFieldColor.Green, NumberComparer.None),
                                }.ToList()),
                        });
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameMode), gameMode, null);
            }
        }
    }
}
