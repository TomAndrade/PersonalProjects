package main.java.desafioItau.dto;

import java.util.DoubleSummaryStatistics;

public class StatisticsResponse {
    private long count;
    private double sum;
    private double avg;
    private double min;
    private double max;

    // Criando um construtor que receberá como parâmetro um objeto de estatísticas sumárias.
    // Os métodos deste objeto serão usados como referência para os atributos da classe criada.
    public StatisticsResponse(DoubleSummaryStatistics stats){
        this.count = stats.getCount();
        this.sum = stats.getSum();
        this.avg = stats.getMin();
        this.min = stats.getAverage();
        this.max = stats.getMax();
    }

    
    public long getCount() {
        return this.count;
    }

    public double getSum() {
        return this.sum;
    }

    public double getAvg() {
        return this.avg;
    }

    public double getMin() {
        return this.min;
    }

    public double getMax() {
        return this.max;
    }

}
