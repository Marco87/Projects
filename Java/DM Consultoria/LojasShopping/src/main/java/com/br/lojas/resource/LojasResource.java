package com.br.lojas.resource;

import java.util.List;
import java.util.Optional;

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

import com.br.lojas.model.Loja;
import com.br.lojas.repository.LojasRepository;

@RestController
@RequestMapping("/loja")
public class LojasResource {

	@Autowired
	private LojasRepository l;

	@PostMapping
	public Loja criar(@Valid @RequestBody Loja loja) {
		return l.save(loja);
	}

	@GetMapping
	public List<Loja> exibir() {
		return l.findAll();
	}

	@GetMapping("get/{id}")
	public ResponseEntity<?> exibirPorId(@PathVariable Long id) {
		Optional<Loja> loja = l.findById(id);

		if (loja.isPresent()) {
			return ResponseEntity.ok(loja);
		} else {
			return ResponseEntity.notFound().build();
		}
	}

	@PutMapping("put/{id}")
	public ResponseEntity<?> atualizar(@PathVariable Long id, @Valid @RequestBody Loja loja) {
		Loja lojaAtualizada = l.findById(id).get();

		if (lojaAtualizada == null) {
			return ResponseEntity.notFound().build();
		} else {
			BeanUtils.copyProperties(loja, lojaAtualizada, "id");
			lojaAtualizada = l.save(lojaAtualizada);
			return ResponseEntity.ok(lojaAtualizada);
		}
	}

	@DeleteMapping("del/{id}")
	public ResponseEntity<?> remover(@PathVariable Long id) {
		Optional<Loja> loja = l.findById(id);

		if (loja.isPresent()) {
			l.deleteById(id);
			return ResponseEntity.noContent().build();
		} else {
			return ResponseEntity.notFound().build();
		}
	}
}
