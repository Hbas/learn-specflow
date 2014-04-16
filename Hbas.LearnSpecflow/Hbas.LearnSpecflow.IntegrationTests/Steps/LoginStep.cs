using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coypu;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Hbas.LearnSpecflow.IntegrationTests.Steps
{
    public class LoginStep : AbstractStep
    {
        [When(@"eu não digitar nada")]
        public void QuandoEuNaoDigitarNada()
        {
            QuandoEuAbrirAPaginaDeLogin();
            EClicarEmSignIn();
        }

        private static void QuandoEuAbrirAPaginaDeLogin()
        {
            CurrentBrowser.Visit("http://localhost:50231/Login");
        }

        private static void EClicarEmSignIn()
        {
            CurrentBrowser.ClickButton("Sign In");
        }

        [Then(@"o sistema não irá permitir meu login")]
        public void EntaoOSistemaNaoIraPermitirMeuLogin()
        {
            EntaoOSistemaIraExibirAMensagem("O campo Login é obrigatório.");
            EntaoOSistemaIraExibirAMensagem("O campo Password é obrigatório.");
        }

        private static void EntaoOSistemaIraExibirAMensagem(string msg)
        {
            Assert.IsTrue(CurrentBrowser.HasContent(msg), "A página não contém: " + msg);
        }

        [When(@"eu utilizar um login e senha válidos")]
        public void QuandoEuUtilizarUmLoginESenhaValidos()
        {
            QuandoEuAbrirAPaginaDeLogin();
            EPreencherComUmLoginValido();
            EClicarEmSignIn();
        }

        private void EPreencherComUmLoginValido()
        {
            CurrentBrowser.FillIn("Login").With("Henrique");
            CurrentBrowser.FillIn("Password").With("123");
        }

        [Then(@"o sistema irá exibir a mensagem de saudação na página inicial")]
        public void EntaoOSistemaIraExibirAMensagemDeSaudacaoNaPaginaInicial()
        {
            EntaoOSistemaIraExibirAMensagem("Bem-vindo Henrique!");
        }       

    }
}
