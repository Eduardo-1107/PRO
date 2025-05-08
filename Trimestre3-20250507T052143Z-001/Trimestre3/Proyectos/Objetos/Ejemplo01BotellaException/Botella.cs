using System;

public class Botella {
    private float capacidad;
    private float contenido;
    private bool abierta = true;

    public Botella() {
        capacidad = 1;
    }
    public Botella(float cap) {
        if (cap <= 0.0)
            //throw new ExceptionCapacidadBotella();
            throw new ExceptionCapacidadBotella("Botella de capacidad negativa.");
        capacidad = cap;
    }
    public void Abrir() {
        abierta = true;
    }
    public void Cerrar() {
        abierta = false;
    }
    public bool EstaLlena() {
        return contenido == capacidad;
    }
    public bool EstaVacia() {
        return contenido == 0.0;
    }
    public float Anadir(float liq) {
        if (abierta) {
            float sobra = liq + contenido - capacidad;
            if (sobra < 0.0f)
                sobra = 0.0f;
            contenido += (liq - sobra);
            return sobra;
        }
        return liq;
    }

    public float Quitar(float liq) {
        if (abierta) {
            float quitado = (liq < contenido) ? liq : contenido;
            contenido -= quitado;
            return quitado;
        }
        return 0.0f;
    }

    public float Contiene() {
        return contenido;
    }

    public float LeCabe() {
        return capacidad;
    }
}
