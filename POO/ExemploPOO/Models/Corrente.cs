namespace ExemploPOO.Models
{
    public class Corrente : Conta       
    {
        public override void Creditar(double valor) //o método abstrato da classe mãe deve ser obrigatoriamente implementado pela classe filha
        {
            base.saldo = valor;     //base indica que o atributo que está sendo alterado pertence à classe mãe
        }
    }
}