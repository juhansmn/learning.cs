using System;

class Geometria {
    public int LadoA { get; set; }
    public int LadoB { get; set; }
    public int LadoC { get; set; }
    public int LadoD { get; set; }

    /*Retângulo
    Triângulo
    Quadrado*/

    public Geometria(int ladoA, int ladoB, int ladoC, int ladoD) {
        this.LadoA = ladoA;
        this.LadoB = ladoB;
        this.LadoC = ladoC;
        this.LadoD = ladoD;
    }

    public Geometria(int ladoA, int ladoB, int ladoC) {
        this.LadoA = ladoA;
        this.LadoB = ladoB;
        this.LadoC = ladoC;
    }

    public Geometria(int ladoA) {
        this.LadoA = ladoA;
        this.LadoB = ladoA;
        this.LadoC = ladoA;
        this.LadoD = ladoA;
    }

    public double Area() {
        int _base = LadoB; 
        int _altura = LadoA;

        //Se for um triângulo:
        if (LadoD == 0 && LadoC != 0)
            return Perimetro();

        //Para um retângulo e um quadrado:
        return _base * _altura;
    }

    public double Perimetro() {
        //Se for retângulo:
        if (LadoD != 0)
            return 2 * (LadoA + LadoB);

        //Se for um triângulo:
        if (LadoD == 0 && LadoC != 0) {
            double p = (LadoA + LadoB + LadoC) / 2;
 
            p = p * (p - LadoA) * (p - LadoB) * (p - LadoC);

            return Math.Sqrt(p);
        }
        //perímetro de um quadrado:
        return LadoA * 4;

    }

    public static void Main() {
        Geometria g = new Geometria(10, 10, 10);
        Console.WriteLine(g.Area().ToString());
        Console.WriteLine(g.Perimetro().ToString());
        Console.ReadKey();
    }

}