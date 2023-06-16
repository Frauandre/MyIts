package com.example.demo.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.example.demo.entities.Fornitore;
import com.example.demo.entities.Bollettino;

@Service
public class BollettiniServiceImpl implements BollettininiService{
    @Autowired
    private BollettinoDao bdao
}
