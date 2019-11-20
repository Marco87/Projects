#Bibliotecas nativas do Python
import os
import time
import re
import requests
import json

#Bibliotecas que nós instalamos
from chatterbot.trainers import ListTrainer
from chatterbot import ChatBot
from selenium import webdriver

class wppbot:
    #Setamos o caminho de nossa aplicação.
    dir_path = os.getcwd()
#Nosso contrutor terá a entrada do nome do nosso 
    def __init__(self, nome_bot):
#Setamos nosso bot e a forma que ele irá treinar.
        self.bot = ChatBot(nome_bot)
        self.bot.set_trainer(ListTrainer)
#Setamos onde está nosso chromedriver.
        self.chrome = self.dir_path+'\chromedriver'
#Configuramos um profile no chrome para não precisar logar no whats toda vez que iniciar o bot.
        self.options = webdriver.ChromeOptions()
        self.options.add_argument(r"user-data-dir="+self.dir_path+"\profile\wpp")
#Iniciamos o driver.
        self.driver = webdriver.Chrome(self.chrome, chrome_options=self.options)

    def inicia(self, nome_contato):
    #Selenium irá entrar no WhatsApp e aguardar 15 segundos até o dom estiver pronto.
        self. driver.get('https://web.whatsapp.com/')
        self.driver.implicitly_wait(15)
    #Selecionamos o elemento da caixa de pesquisa do WhatsApp pela classe.
        self.caixa_de_pesquisa = seçf.driver.find_element_by_class_name('jN-F5')

    #Escreveremos o nome do contato na caixa de pesqiosa e aguardaremos 2 segundos
        self.caixa_de_pesquisa.send_keys(nome_contato)
        time.sleep(2)
    #Vamos procurar o contato/grupo que está em um span e possui o título igual que buscamos e vamos clicar
        self.contato = self.driver.find_element_by_class_xpath('//span[@title = "{}"]'.format(nome_contato))
        self.contato.click()
        time.sleep(2)

    #Ao usar este método, devemos enviar a mensagem de saudação em uma lista.
    def saudacao(self, frase_inicial):
    #Setamos a caixa de mensagem como o elemento com a classe _2S1VP
        self.caixa_de_mensagem = self.driver.find_element_by_class_name('_2S1VP')
    #Validamos se a frase inicial é uma lista.
        if type(frase_inicial) == list:
    #Realizamos um for para enviar cada mensagem na lista.
            for frase in frase_inicial:
    #Escrevemos a frase na caixa de mensagem.
                self.caixa_de_mensagem.send_keys(frase)
                time.sleep(1)
    #Setamos o botão de enviar e clicamos para enviar.
                self.botao_enviar = self.driver.find_element_by_class_name('_35EW6')
                self.botao_enviar.click()
                time.sleep(1)
        else:
            return False

    def escuta(self):
    #Vamos setar todas as mensagens no grupo.
        post = self.driver.find_element_by_class_name('_3_7SH')
    #Vamos pegar o índice da última conversa.
        ultimo = len(post) - 1
    #Vamos pegar o texto da última conversa e retornar.
        texto = post[ultimo].find_element_by_css_selector('span.selectable-text').text
        return texto

    #Nosso método responde irá receber o parâmetro texto que seria o retorno do método escuta.
    def responde(self, texto):
    #Setamos a resposta do bot na variável response.
        reponse = self.bot.get_response(texto)
    #Transforma em string essa resposta.
        response = str(response)
    #Colocamos o prefixo bot: no início.
        response = 'bot: ' + response
    #Setamos caixa de mensagens preenchemos com a resposta e clicamos em enviar.
        self.caixa_de_mensagem = self.driver.find_element_by_class_name('_2S1VP')
        self.caixa_de_mensagem.send_keys(response)
        time.sleep(1)
        self.botao_enviar = self.driver.find_element_by_class_name('_35EW6')
        self.botao_enviar.click()

    #Setamos uma lista com diálogos conectados entre si.
    conv = ['oi', 'olá', 'tudo bem?', 'estou bem!', 'o que você está fazendo?', 'como estão as coisas?']
    #No método train do Chatterbot o mesmo é treinado.
    bot.train(conv)

    #Nosso método irá receber o parâmetro nome_pasta que deverá estar o txt da legenda do filme
    def treina(self, nome_pasta):
    #Listamos todos os arquivos dentro da pasta e para cada linha treinamos nosso bot.
        for treino in os.listdir(nome_pasta):
            conversas = open(nome_pasta+'/'+treino, 'r').readlines().self.bot.train(conversas)

    