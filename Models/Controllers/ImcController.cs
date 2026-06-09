using Microsoft.AspNetCore.Mvc;
using CadastroAlunos.Models;
using System;

namespace CadastroAlunos.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Imc());
        }

        [HttpPost]
        public IActionResult Calcular(Imc model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Cálculo do IMC (Server Side)
            model.Resultado = model.Peso / (model.Altura * model.Altura);
            model.Resultado = Math.Round(model.Resultado, 2);

            // Classificação do IMC
            if (model.Resultado < 18.5)
                model.Classificacao = "Abaixo do peso";
            else if (model.Resultado < 25)
                model.Classificacao = "Peso normal";
            else if (model.Resultado < 30)
                model.Classificacao = "Sobrepeso";
            else
                model.Classificacao = "Obesidade";

            return View("Index", model);
        }
    }
}
