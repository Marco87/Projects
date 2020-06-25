package com.example.marco.imc

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        btnIMC.setOnClickListener {
            val peso: Double = txtPeso.text.toString().toDouble()
            val altura: Double = txtAltura.text.toString().toDouble()

            calcularIMC(altura, peso)
        }
    }

    fun calcularIMC(a: Double, p: Double){

        val imc: Double = (p / (a * a))

        classificarIMC(imc)
    }

    fun classificarIMC(imc: Double) {
        var msg: String =
            if (imc < 17)
                "Peso muito baixo"
            else if (imc < 18.49)
                "Baixo peso"
            else if (imc < 24.99)
                "Peso normal"
            else if (imc < 29.99)
                "Sobrepeso"
            else if (imc < 34.99)
                "Obesidade classe I"
            else if (imc < 39.99)
                "Obesidade classe II"
            else
                "Obesidade classe III"

        retornarMensagem(msg)
    }

    fun retornarMensagem(msg: String) {
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show()
        txtImc.setText(msg)
    }
}
