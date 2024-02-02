using Aplicacao.Servicos;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Protheus.src.Aplicacao.Filtro
{
    public class ValidacaoModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            foreach (var argument in context.ActionArguments.Values)
            {
                var (valido, mensagem) = Validacao.NaoNulo(argument);

                if (!valido)
                {
                    context.Result = new BadRequestObjectResult(new { message = mensagem });
                    return;
                }
            }
        }
    }
}
