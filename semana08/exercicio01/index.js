function insert(num){
var number = document.getElementById('last-calc').innerHTML;
document.getElementById('last-calc').innerHTML = number + num;
}

function clean(){
document.getElementById('last-calc').innerHTML = "";
document.getElementById('calculo').innerHTML = "";

}

function delet (){
var del = document.getElementById('last-calc').innerHTML;
document.getElementById('last-calc').innerHTML= del.substring(0, del.length -1);
}

function calcular(){
    var resultado = document.getElementById('last-calc').innerHTML;
    if(resultado)
    {
        document.getElementById('calculo').innerHTML = eval(resultado).toFixed(2);;
    }
    else
    {
        document.getElementById('calculo').innerHTML = ""
    }
}



  