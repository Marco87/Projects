package com.br.lojas.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.br.lojas.model.Loja;

public interface LojasRepository extends JpaRepository<Loja, Long> {

}
