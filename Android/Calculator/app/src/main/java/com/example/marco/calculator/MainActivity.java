package com.example.marco.calculator;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    //Declaração de variáveis
    private float x1;
    private float x2;

    //Declaração de objetos
    EditText n1, n2;
    TextView result;
    Button bSom, bSub, bMul, bDiv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        inicializarBotoes();
    }

    public void atribuirValores() {
        n1 = findViewById(R.id.txtX1);
        n2 = findViewById(R.id.txtX2);
        result = findViewById(R.id.txtResult);

        setX1(Float.parseFloat(n1.getText().toString()));
        setX2(Float.parseFloat(n2.getText().toString()));
    }

    public void inicializarBotoes() {
        bSom = findViewById(R.id.btnSoma);
        bSub = findViewById(R.id.btnSub);
        bMul = findViewById(R.id.btnMult);
        bDiv = findViewById(R.id.btnDiv);

        acionarBotoes();
    }

    public void acionarBotoes() {
        bSom.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                somar();
            }
        });

        bSub.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                subtrair();
            }
        });

        bMul.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                multiplicar();
            }
        });

        bDiv.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                dividir();
            }
        });
    }

    public float getX1() {
        return x1;
    }

    public void setX1(float x1) {
        this.x1 = x1;
    }

    public float getX2() {
        return x2;
    }

    public void setX2(float x2) {
        this.x2 = x2;
    }

    public void somar() {
        atribuirValores();
        float res;
        res = getX1() + getX2();
        result.setText(Float.toString(res));
    }

    public void subtrair() {
        atribuirValores();
        float res;
        res = getX1() - getX2();
        result.setText(Float.toString(res));
    }

    public void multiplicar() {
        atribuirValores();
        float res;
        res = getX1() * getX2();
        result.setText(Float.toString(res));
    }

    public void dividir() {
        atribuirValores();
        float res;
        res = getX1() / getX2();
        result.setText(Float.toString(res));
    }
}
