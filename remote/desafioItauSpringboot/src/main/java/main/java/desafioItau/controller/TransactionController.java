package main.java.desafioItau.controller;

import java.time.OffsetDateTime;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import jakarta.validation.Valid;
import main.java.desafioItau.dto.TransactionRequest;
import main.java.desafioItau.service.TransactionService;

@RestController
@RequestMapping("/transacao")  //endpoint
public class TransactionController {

    private TransactionService transactionService;

    public TransactionController(TransactionService transactionService) {
        this.transactionService = transactionService;
    }
    // Um map que exibe a transação.
    @PostMapping
    public ResponseEntity<Void> createTransaction(@Valid @RequestBody TransactionRequest request){
        // Caso o request ter como retorno um horário que esteja no futuro, lance o erro 422.
        if (request.getDatahora().isAfter(OffsetDateTime.now()) || request.getValor() <= 0){
            return ResponseEntity.unprocessableEntity().build();
        }
        // O serviço adiciona a transação contendo o valor e o carimbo de data e hora.
        transactionService.addTransactions(request.getValor(),request.getDatahora());
        return ResponseEntity.status(HttpStatus.CREATED).build();
    }
    // Um map que deleta todas as transações.
    @DeleteMapping
    public ResponseEntity<Void> clearTransactions(){
        transactionService.clearTransactions();
        return ResponseEntity.ok().build();
    }

}
