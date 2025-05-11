package desafioItau;

import java.time.OffsetDateTime;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotNull;

public class Transaction {

    @NotNull
    @Min(0)
    private double valor;
    private OffsetDateTime datahora;
    
}
