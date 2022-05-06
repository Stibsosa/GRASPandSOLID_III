//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Se crea una interfase que sustituye a AllInOnePrinter para cumplir LSP
    public interface IPrinter
    {
        void Printer(Recipe recipe);
    }
}