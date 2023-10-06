namespace PasswordApp
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Ingrese un email: ");
            string email = Console.ReadLine();

            Usuario uPrueba = new Usuario(email); //usuario de membresia

            Password oPassword = null;

            Console.WriteLine("Ingrese el largo del password: ");
            int tamanio = int.Parse(Console.ReadLine());
            oPassword = new Password(tamanio);

            //Mostrar el valor del password:
            Console.WriteLine("El valor del password es: " + oPassword.Valor);
            Console.WriteLine("Es fuerte?" + (oPassword.EsFuerte() ? "SI" : "NO"));

            uPrueba.ResetPass(oPassword);
        }
    }
}