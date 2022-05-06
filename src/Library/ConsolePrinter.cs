//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Se crea la clase ConsolePrinter, que imprime la receta por consola para aplicar Polimorfismo
    public class ConsolePrinter : IPrinter
    {
        public void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }

    }
}