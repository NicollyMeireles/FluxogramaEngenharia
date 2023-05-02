﻿Console.WriteLine("-- Fluxograma de Engenharia --");

Console.WriteLine("O objeto se move? Responda com S/N");
bool resposta1 = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.WriteLine("Deveria se mover?");
bool resposta2 = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (resposta1)
{
    if (resposta2)
    {
       Console.ForegroundColor = ConsoleColor.DarkBlue;
       mensagem = "Ótimo";
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        mensagem = "Use a Silver Tape.";
    }
}

else
{
    if (resposta2)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        mensagem = "Use o WD-40";
    }

    else
    {
      Console.ForegroundColor = ConsoleColor.White;
      mensagem = "Ótimo";
    }
}

Console.WriteLine("");
Console.WriteLine(mensagem);
Console.WriteLine("");
Console.ResetColor();
