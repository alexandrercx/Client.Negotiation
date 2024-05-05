using Client.Negotiation.Domain.Entity;
using Client.Negotiation.Domain.Interface.Repository;
using Client.Negotiation.Domain.Interface.Service;

namespace Client.Negotiation.Domain.Service
{
    public class FinancialProductService : IFinancialProductService
    {
        private readonly IFinancialProductRepository _financialProductRepository;
        public FinancialProductService(IFinancialProductRepository financialProductRepository)
        {
            _financialProductRepository = financialProductRepository;
        }

     

        public bool UpdateFinancialProduct(FinancialProduct financialProductParam)
        {
            var financialProduct = _financialProductRepository.GetById(financialProductParam.Id);
            if (financialProduct == null)
            {
                throw new FormatException("Financial Product not found");
            }
            financialProduct.Ativo = financialProductParam.Ativo;
            financialProduct.Nome = financialProductParam.Nome;
            financialProduct.TaxaJurosAnual = financialProductParam.TaxaJurosAnual;
            financialProduct.AplicacaoMinima = financialProductParam.AplicacaoMinima;
            financialProduct.QtdCotaTotal = financialProductParam.QtdCotaTotal;
            financialProduct.QtdCotaAtual = financialProductParam.QtdCotaAtual;
            financialProduct.Carencia = financialProductParam.Carencia;
            financialProduct.Vencimento = financialProductParam.Vencimento;
            financialProduct.CaracteristicasAtivo = financialProductParam.CaracteristicasAtivo;
            financialProduct.Ativo = financialProductParam.Ativo;

            _financialProductRepository.Update(financialProduct);
            _financialProductRepository.SaveChanges();
            return true;
        }

    }
}
