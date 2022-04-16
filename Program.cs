double alcance, altura, rad, v, anguloGraus;
const double g = 9.80665 ;

Console.WriteLine("-- Projétil --");
Console.Write("Entre com a velocidade, em m/s..:");
v = Convert.ToDouble (Console.ReadLine());

Console.Write("Entre com o ângulo, em graus....:");
anguloGraus = Convert.ToDouble (Console.ReadLine());

rad = anguloGraus * Math.PI / 180;

alcance = Math.Pow(v * Math.Sin(rad), 2) / (2*g);

altura = (Math.Pow(v,2) * Math.Sin(rad * 2)) / g;

Console.WriteLine($"Alcance.........:{alcance:N} m");
Console.WriteLine($"Altura máxima...:{altura:N} m ");