open System

[<EntryPoint>]
let main argv =
    printfn "Hello from F#"
    Console.WriteLine("Press any key to exit...")
    Console.ReadKey() |> ignore
    0 // return an integer exit code