package com.example.demo.service;

import java.util.List;
import com.example.demo.entities.Fornitore;
import com.example.demo.entities.Bollettino;

public interface BollettininiService{

    List<Fornitore> getFornitori();
    Fornitore getFornitoreById(int id);
    Fornitore addFornitore(Fornitore f);

    List<Bollettino> getBollettini();
    Bollettino getBollettinoById(int id);
    Bollettino addBollettino(Bollettino b);
    List<Bollettino> getBollettiniByUsername(String username);

}