package com.br.lojas.resource;

import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.delete;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.web.context.WebApplicationContext;

@RunWith(SpringRunner.class)
@SpringBootTest
public class LojasResourceTest {

	@Autowired
	public WebApplicationContext context;

	private MockMvc mvc;

	@Before
	public void setup() {
		this.mvc = MockMvcBuilders.webAppContextSetup(this.context).build();
	}

	// Exibir Lojas (Sucesso e Falha)
	@Test
	public void testarExibirLojasSucesso() throws Exception {
		String url = "/loja";
		this.mvc.perform(get(url)).andExpect(status().isOk());
	}

	@Test
	public void testarExibirLojasFalha() throws Exception {
		String url = "/loja/get";
		this.mvc.perform(get(url)).andExpect(status().isNotFound());
	}

	// Exibir por Id (Sucesso e Falha)
	@Test
	public void testarExibirIdSucesso() throws Exception {
		String url = "/loja/get/2";
		this.mvc.perform(get(url)).andExpect(status().isOk());
	}

	@Test
	public void testarExibirIdFalha() throws Exception {
		String url = "/loja/get/20";
		this.mvc.perform(get(url)).andExpect(status().isNotFound());
	}

	// Remover (Sucesso e Falha)
	@Test
	public void testarRemoverSucesso() throws Exception {
		String url = "/loja/del/1";
		this.mvc.perform(delete(url)).andExpect(status().isNoContent());
	}

	@Test
	public void testarRemoverFalha() throws Exception {
		String url = "/loja/del/100";
		this.mvc.perform(delete(url)).andExpect(status().isNotFound());
	}

}
