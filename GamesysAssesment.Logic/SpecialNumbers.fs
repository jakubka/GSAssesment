namespace GamesysAssesment.Logic

module SpecialNumbers =
    /// <summary>
    /// Returns nth number in the input list. List is indexed from 1.
    /// </summary>
    let getNthLargestNumber (n : int) (orderedSeries : list<float>) = 
        if n < 1 || n > orderedSeries.Length then
            invalidArg "n" "n must be positive integer lower than the lenght of the list"

        orderedSeries.[n - 1]

    /// <summary>
    /// Returns number from the list which is closest (by absolute difference) to the given one.
    /// </summary>
    let getClosestNumber (n : float) (orderedSeries : list<float>) =
        // (could be optimized, because we know that series is sorted)
        orderedSeries |> List.minBy (fun x -> abs(x - n))