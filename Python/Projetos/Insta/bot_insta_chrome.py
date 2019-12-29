from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time
import random
import getpass

class InstagramBot:
    def __init__(self, username, password):
        self.username = username
        self.password = password
        self.driver = webdriver.Chrome(executable_path=r'chromedriver')

    def login(self):
        driver = self.driver
        driver.get('https://www.instagram.com')

login = input("Digite o seu login no Instagram: ")
senha = getpass.getpass("Digite a sua senha: ")
bot = InstagramBot(login, senha)
bot.login()
