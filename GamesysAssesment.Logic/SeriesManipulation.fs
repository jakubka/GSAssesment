namespace GamesysAssesment.Logic

module SeriesManipulation =
    open System

    /// <summary>
    /// Rounds input number to nearest quarter (X.0, X.25, X.50, X.75).
    /// </summary>
    /// <param name="n">Input double</param>
    let roundToQuarter (n : float) =
        Math.Round(n * 4.0, MidpointRounding.AwayFromZero) / 4.0