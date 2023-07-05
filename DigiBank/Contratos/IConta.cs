
using DigiBank.Classes;

namespace DigiBank.Contratos
{
    public interface IConta
    { 

        void Deposita(double valor);

        bool Sacar(double valor);

        double ConsultaSaldo();

        string GetCodigoDoBanco();

        string GetNumeroAgencia();

        string GetNumeroConta();

        List<Extrato> GetExtratoList();

    }
}
