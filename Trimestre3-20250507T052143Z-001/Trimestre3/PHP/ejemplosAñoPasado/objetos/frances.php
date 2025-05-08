<?php
include_once 'persona.php';
class Frances extends Persona
{
    public function __construct($nombre, $edad = 50){
        Parent::__construct($nombre, $edad);
    }

    public function saludo(){
        return "Allò, je m'apelle $this->nombre et j'ai $this->edad ans.";
    }
}
