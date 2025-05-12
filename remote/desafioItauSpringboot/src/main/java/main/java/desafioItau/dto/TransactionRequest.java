package main.java.desafioItau.dto;

import java.time.OffsetDateTime;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotNull;

public class TransactionRequest {
    
    @NotNull
    @Min(0)
    private Double valor;

    @NotNull
    private OffsetDateTime datahora;


    public Double getValor() {
        return this.valor;
    }

    public OffsetDateTime getDatahora() {
        return this.datahora;
    }

}
