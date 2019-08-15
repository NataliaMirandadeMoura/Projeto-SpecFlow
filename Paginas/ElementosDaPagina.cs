using MyProject.Specs.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Specs.Paginas
{
    public class ElementosDaPagina: PaginaBase
    {
        public ElementosDaPagina(IWebDriver navegador) : base(navegador)
        {

        }
        public IWebElement CampoDePesquisa => RetornarPorNome("");
        public IWebElement LogoHome => RetornarPorId("");
        public IWebElement ResultadoDaPesquisa => RetornarPorId("");

       
    }
}
