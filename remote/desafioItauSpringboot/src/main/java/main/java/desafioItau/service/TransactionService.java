package main.java.desafioItau.service;
// Requer notação se é um service.

import java.time.OffsetDateTime;
import java.util.DoubleSummaryStatistics;
import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedDeque;
import org.springframework.stereotype.Service;

import desafioItau.Transaction;

@Service
public class TransactionService {
    private final Queue<Transaction> transactions = new ConcurrentLinkedDeque<>();

    // Este método cria um vetor do tipo Queue que adiciona transações.
    public void addTransactions(Transaction transaction){
        transactions.add(transaction);
    }
    // este método simplesmente limpa o vetor.
    public void clearTransactions(){
        transactions.clear();
    }

    public main.java.desafioItau.controller.DoubleSummaryStatistics getStatistics(){
        // O OffsetDateTime tem a mesma premissa que o LocalDateTime.
        OffsetDateTime now = OffsetDateTime.now();
        // O que acontece aqui: o vetor está sendo filtrado para pegar o horário de 60 segundos atrás via lambda.
        return (main.java.desafioItau.controller.DoubleSummaryStatistics) (transactions.stream().filter(t -> t.getDatahora().isAfter(now.minusSeconds(60))));
            // Retorna o valor da lambda.
            //.mapToDouble(Transaction::getValoralor)
            //.summmaryStatistics();
    }
    public void addTransactions(Double valor, OffsetDateTime datahora) {
        throw new UnsupportedOperationException("Unimplemented method 'addTransactions'");
    }
}
