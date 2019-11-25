from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time
import random

class InstagramBot:
    def __init__(self, username, password):
        #self.username = username
        #self.password = password
        self.driver = webdriver.Chrome(executable_path=r'chromedriver')

    def login(self):
        driver = self.driver
        driver.get('https://www.instagram.com')


marcoBot = InstagramBot('marco.alencastro', 'etevma10')
marcoBot.login()