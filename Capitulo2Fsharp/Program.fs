open PeriodoDeTempo
open System

let exemploUsoDeExpressao numero = 
    let resultado =
        if numero % 2 = 0 then 2 else 0

    printfn "%i" resultado

[<EntryPoint>]
let main argv =
    let periodo = {DataInicial = DateTime.Parse "20/08/2019"
        ;DataFinal = DateTime.Parse "31/08/2019"}

    let datasParaTeste = 
        [|
            DateTime.Parse "18/08/2019"
            DateTime.Parse "22/08/2019"
            DateTime.Parse "01/09/2019"
        |]

    for data in datasParaTeste do
        let dataEstaNoPeriodo = verificarSeDataEstaEntreOPeriodo periodo data
        printfn "%b" dataEstaNoPeriodo

        Console.ReadKey() |> ignore
    0