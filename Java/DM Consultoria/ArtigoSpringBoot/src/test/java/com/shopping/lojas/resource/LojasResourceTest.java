package com.shopping.lojas.resource;

import static org.assertj.core.api.Assertions.assertThat;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.get;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.status;

import org.aspectj.lang.annotation.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;
import org.springframework.web.context.WebApplicationContext;

import com.shopping.lojas.model.Loja;

@RunWith(SpringRunner.class)
@SpringBootTest
public class LojasResourceTest {

	@Autowired
	public WebApplicationContext context;
	
	private MockMvc mvc;
/*
	@Before
	public void setup() {
		this.mvc = MockMvcBuilders.webAppContextSetup(this.context).build();
	}
*/
	
	@Test
	public void testarGetIdSucesso() throws Exception {
		String url = "/lojas/1";
		this.mvc.perform(get(url))
		.andExpect(status().isOk());
	}
	
}
