namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        public bool NaoDeveConterONumero10NaLista(List<int> lista, int numero)
        {
            var naoContem = !lista.Contains(numero);
            return naoContem;
        }

        public List<int> DeveMultiplicarOsElementosDaListaPor2(List<int> lista)
        {
            var listaMultiplicada = lista.Select(x => x * 2).ToList();
            return listaMultiplicada;
        }

        public int DeveRetornar9ComoMaiorNumeroDaLista(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
