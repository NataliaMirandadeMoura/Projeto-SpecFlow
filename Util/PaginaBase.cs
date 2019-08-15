using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Specs.Util
{
    public abstract class PaginaBase
    {
        public IWebDriver _navegador;

        protected PaginaBase(IWebDriver navegador)
        {
            _navegador = navegador;
        }

        protected IWebElement RetornarPorNome(string nome) => _navegador.FindElement(By.Name(nome));

        protected IWebElement RetornarPorId(string id) => _navegador.FindElement(By.Id(id));

        protected IWebElement RetornarPorClass(string classe) => _navegador.FindElement(By.ClassName(classe));

    }
}

    

