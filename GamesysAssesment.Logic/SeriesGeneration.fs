namespace GamesysAssesment.Logic

module SeriesGeneration =
    let calculateFirstNumber (x : float) =
        ((0.5 * x * x) + (30.0 * x) + 10.0) / 25.0

    let calculateGrowthRate (y : float) (firstNumber : float) =
        y * 0.02 / 25.0 / firstNumber

    /// <summary>
    /// Creates infinite sequence of doubles with progress computed based on input parameters.
    /// </summary>
    /// <param name="x">Base for the first number</param>
    /// <param name="y">Base for the growth rate</param>
    let series x y =
        let firstNumber = calculateFirstNumber x
        let growthRate = calculateGrowthRate y firstNumber

        // index is 0 based, so first item has to be skipped, to make it start with 1
        let seqNumbers = Seq.initInfinite id |> Seq.skip 1 |> Seq.map (fun index -> growthRate * (pown firstNumber index))

        Seq.append [firstNumber] seqNumbers