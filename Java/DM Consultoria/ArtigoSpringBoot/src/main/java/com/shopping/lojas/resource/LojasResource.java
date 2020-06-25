package com.shopping.lojas.resource;

import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.BeanUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.shopping.lojas.model.Loja;
import com.shopping.lojas.repository.Lojas;

@RestController
@RequestMapping("/lojas")
public class LojasResource {

	@Autowired
	private Lojas lojas;

	@PostMapping
	public Loja adicionar(@Valid @RequestBody Loja loja) {
		return lojas.save(loja);
	}

	@GetMapping
	public List<Loja> listar() {
		return lojas.findAll();
	}

	@GetMapping("/{id}")
	public ResponseEntity<Loja> buscar(@PathVariable Long id) {
		Loja loja = lojas.findById(id).get();

		if (loja == null) {
			return ResponseEntity.notFound().build();
		}

		return ResponseEntity.ok(loja);
	}

	@PutMapping("/{id}")
	public ResponseEntity<Loja> atualizar(@PathVariable Long id, @Valid @RequestBody Loja loja) {
		Loja existente = lojas.findById(id).get();

		if (loja == null) {
			return ResponseEntity.notFound().build();
		}

		BeanUtils.copyProperties(loja, existente, "id");

		existente = lojas.save(existente);

		return ResponseEntity.ok(existente);
	}

	@DeleteMapping("/{id}")
	public ResponseEntity<Loja> remover(@PathVariable Long id) {
		Loja loja = lojas.findById(id).get();

		if (loja == null) {
			return ResponseEntity.notFound().build();
		}

		lojas.delete(loja);

		return ResponseEntity.noContent().build();
	}
}
