namespace PrimeiroPooAtividade
{
    public class personagem
    {
        public string nome= "Alex";

        public int idade = 20;


        public float atacarFraco (float forca, float chute )
        {
            return forca*chute;
        }
        
        public float atacarForte (float forca, float chute, float fogo )
        {
            return forca+chute+fogo;
        }
    }
}