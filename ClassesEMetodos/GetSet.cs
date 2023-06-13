﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {           // Get Lê - Set Altera
        private string Marca;
        private string Modelo;  // Atributos
        private uint Cilindrada; // Uint não aceita valores negativos

        public Moto(string marca, string modelo, uint cilindrada) {  // Construtor por parâmetros
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto() {  // Construtor por padrão

        }

        public string GetMarca() { // Return quando retorna um valor
            return Marca; 
        }

        public void SetMarca(string marca) { // Void quando não volta nada
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            Cilindrada = cilindrada;
        }


    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja-ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("Titan");
            moto2.SetCilindrada(160);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        }
    }
}
