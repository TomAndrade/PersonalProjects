package desafioItau;

import java.time.OffsetDateTime;

public class Transaction {
    private double valor;
    private OffsetDateTime datahora;

    public double getValor() {
        return this.valor;
    }

    public OffsetDateTime getDatahora() {
        return this.datahora;
    }
    // Não é necessário o uso de setters aqui, já que os atributos já fazem este papel.
    public Transaction(final double valor,final OffsetDateTime datahora){
        this.valor = valor;
        this.datahora = datahora;
    }
}
