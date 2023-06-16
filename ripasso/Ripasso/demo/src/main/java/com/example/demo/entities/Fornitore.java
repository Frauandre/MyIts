package com.example.demo.entities;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name="fornitori")
public class Fornitore {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    
    private int id;
    private String conto;
    private String codice;
    private String causale;
    private double importo;

}
