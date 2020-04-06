module FuncoesDeAltaOrdem


//let imprimirNomes nomes =
//    for nome in nomes do
//        printfn "Olá %s." nome


//let imprimirDobroDosNumeros numeros = 
//    for numero in numeros do
//        printfn "%i." (numero * 2)

let executarAcaoSobreElementos lista acao = lista |> List.iter acao

let imprimirNomes nomes = 
    executarAcaoSobreElementos nomes (printfn "Olá %s")

let imprimirDobroDosNumeros numeros = 
    executarAcaoSobreElementos numeros (fun numero -> printfn "%i" (numero * 2))

let somaCom5 numero = numero + 5

let somaCom5ViaLambda = fun numero -> numero +5

let multiplicarEImprimirNumero multiplicador numero = 
    printfn "%i." (numero * multiplicador)

let imprimirListaDeNumeros multiplicador numeros = 
    executarAcaoSobreElementos numeros (multiplicarEImprimirNumero multiplicador)


let imprimirNumeroCurrying multiplicador = 
    let imprimirNumero numero = printfn "%i." (numero * multiplicador)
    imprimirNumero