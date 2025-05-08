<?php
class Persona {
    public $nombre;
    protected $edad;
    public function __construct($n, $edad){
        $this -> nombre = $n;
        $this -> edad = $edad;
    }
    public function saludo(){
        return "Hola, me llamo $this->nombre y tengo $this->edad años";
    }
}
