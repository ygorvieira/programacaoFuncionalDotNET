namespace Modulos

[<RequireQualifiedAccess>]
module FuncoesDeEscrita =

    let escrever nome = printfn "seu nome é: %s" nome

module FuncoesDeEscritaDeNumeros = 

    let escrever idade = printfn "sua idade é: %i anos" idade

module FuncoesDeEscritaUtilizandoOutrosModulos = 
    
    let escrever nome idade = 
        FuncoesDeEscrita.escrever nome
        FuncoesDeEscritaDeNumeros.escrever idade

namespace OutroNamespace
open Modulos


module FuncoesDeEscritaUtilizandoOutroNamespace = 
    
    let escreverNome nome idade = 
        Modulos.FuncoesDeEscrita.escrever nome
        Modulos.FuncoesDeEscritaDeNumeros.escrever idade