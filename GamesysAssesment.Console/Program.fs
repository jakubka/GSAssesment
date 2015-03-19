open GamesysAssesment.Logic
open System

[<EntryPoint>]
let main argv = 
    let read () = 
        Console.ReadLine ()

    printf "Enter x: "
    let x = read () |> float
    
    printf "Enter y: "
    let y = read () |> float

    printf "Enter z: "
    let z = read () |> float

    printf "Enter length: "
    let length = read () |> int

    let orderedSeries = SeriesGeneration.series x y |> Seq.take length |> Seq.sort |> List.ofSeq
    let orderedRoundedSeries = orderedSeries |> Seq.map SeriesManipulation.roundToQuarter |> List.ofSeq
    let number1 = SpecialNumbers.getNthLargestNumber 3 orderedRoundedSeries
    let number2 = SpecialNumbers.getClosestNumber (1000.0 / z) orderedRoundedSeries

    printfn ""
    printfn "Series: %A" orderedSeries
    printfn "Rounded series: %A" orderedRoundedSeries
    printfn "Number 1: %A" number1
    printfn "Number 2: %A" number2

    printfn ""
    printfn "Press any key to finish"

    read () |> ignore

    0
