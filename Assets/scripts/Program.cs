using System;

/*

Probabilidades v0.1

Para hacer uso de este script, se debe crear un objeto de tipo Probabilidad con 3 argumentos:

1. La cantidad de rooms.
2. El mínimo de probabilidad.
3. El máximo de probabilidad.

Luego se generarán probabilidades aleatorias para cada room (asignándole índices numéricos a cada una).

Para acceder a las probabilidades se debe hacer uso de las funciones implementadas dentro de la clase Probabilidad.

*/

class Probabilidad
{

    private Random random = new Random();

    private int rooms_amount;

    private double[] rooms;

    private double minima_probabilidad = 0.0;
    private double maxima_probabilidad = 100.0;

    private double randomNumber () {

        return minima_probabilidad + random.NextDouble() * (maxima_probabilidad - minima_probabilidad);

    }

    private void generateRooms () {

        for (int i = 0; i < this.rooms_amount; i++) {

            rooms[i] = this.randomNumber();

        }

    }

    public Probabilidad (int n, double minimum = 0.0, double maximum = 100.0) {

        this.rooms_amount = n;
        this.rooms = new double[n];
        this.minima_probabilidad = minimum;
        this.maxima_probabilidad = maximum;

        this.generateRooms();

    }

    public double[] getRooms () {

        return this.rooms;

    }

    public double getRoom (int i) {

        return this.rooms[i];

    }

    public void showRooms () {

        for (int i = 0; i < this.rooms_amount; i++) {

            double aux = Math.Round(rooms[i], 2);
            Console.Write(aux + " ");

        }

        Console.WriteLine("\n");

    }

}

class Program
{
    static void Main()
    {
        
        Probabilidad ejemplo = new Probabilidad(10, 20.0, 40.0);

        ejemplo.showRooms();

    }
}