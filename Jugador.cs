using System;

namespace BankAccountNS
{
    public class Jugador
    {
        private string nombre;
        private int vida;
        private double oro;
        private bool npc;
        private int resistencia;

        public Jugador()
        {
        }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.vida = 100;
            this.oro = 0;
            this.npc = false;
            this.resistencia = 50;
        }

        public string GetNombre() { return nombre; }
        public int GetVida() { return vida; }
        public double GetOro() { return oro; }
        public bool GetNpc() { return npc; }
        public int GetResistencia() { return resistencia; }

        public void cambiarNombre(string nuevoNombre)
        {
            if (nuevoNombre == null)
            {
                throw new ArgumentNullException();
            }
            nombre = nuevoNombre;
        }

        public void anyadirOro(int cantidad)
        {
            oro = oro + cantidad;
        }

        public void quitarOro(int cantidad)
        {
            if (cantidad > oro)
            {
                throw new ArgumentOutOfRangeException();
            }
            oro = oro - cantidad;
        }

        public void asignarNPC()
        {
            npc = true;
        }

        public void desasignarNPC()
        {
            npc = false;
        }

        public void anyadirResistencia()
        {
            if (npc == true)
            {
                throw new Exception("Error de resistencia, este personaje es un npc");
            }
            resistencia = resistencia + 10;
        }

        public void quitarResistencia()
        {
            if (resistencia <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            resistencia = resistencia - 10;
        }
    }
}