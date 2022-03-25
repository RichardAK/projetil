Console.WriteLine("--projetil--\n");

Console.Write("entre com a velocidade em m/s:");
double velocidade = Convert.ToDouble(Console.ReadLine());

Console.Write("entre com o angulô em graus: ");
double anguloemgraus = Convert.ToDouble(Console.ReadLine());

double anguloemRadianos = anguloemgraus * (Math.PI/180);
const double gravidade =  9.80665;

double altura = (Math.Pow(velocidade*Math.Sin(anguloemRadianos),2))/(2* gravidade);
double alcance = (Math.Pow(velocidade ,2) *Math.Sin(2* anguloemRadianos))/gravidade; 

Console.WriteLine($"\n Alcance...:{alcance:n2} m"); 
Console.WriteLine($"Altura max...:{altura:n2} m"); 

