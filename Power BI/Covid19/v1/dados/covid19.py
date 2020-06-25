#!/usr/bin/env python
# coding: utf-8

# ![](https://www.i9treinamentos.com/wp-content/uploads/elementor/thumbs/A-pandemia-de-Coronav%C3%ADrus-e-o-pandem%C3%B4nio-na-economia-omnnp6emx1qczr92vjwhtnoa1impqfrsl3zkw6c5g4.gif)

# ### Fonte dos dados: https://covid.saude.gov.br/
# ### Secretarias Estaduais de Saúde. Brasil, 2020

# ![](https://covid.saude.gov.br/assets/imgs/logo-app.png)

# ### Importando as bibliotecas necessárias

# In[1]:


import pandas as pd
import matplotlib.pyplot as plt
import numpy as np


# ### Base COVID

# In[2]:


#Carregando os dados

df_covid = pd.read_excel("data/arquivo_geral.xlsx", sep=";")


# In[9]:


#Removendo as features desnecessárias

df_covid = df_covid.drop(columns=['coduf', 'codmun', 'codRegiaoSaude', 'nomeRegiaoSaude', 'populacaoTCU2019'])


# In[22]:


#Renomeando as colunas

df_covid = df_covid.rename(columns={'estado':'siglaEstado', 'Recuperadosnovos':'recuperadosNovos'})


# In[32]:


#Trocando os valores nulos por zero

df_covid = df_covid.fillna(0)


# ### Base Estados

# In[24]:


#Carregando os dados

df_estados = pd.read_excel("data/estados_brasil.xlsx")


# In[26]:


#Removendo as features desnecessárias

df_estados = df_estados.drop(columns=['IBGE', 'Qtd Mun', 'Sintaxe'])


# In[28]:


#Renomeando as colunas

df_estados = df_estados.rename(columns={'Estado':'estado', 'UF':'siglaEstado', 'Região':'regiao'})


# In[67]:


#Retirando a palavra 'Região' da coluna 'regiao'

df_estados['regiao'] = df_estados['regiao'].str.replace("Região ", "")


# In[ ]:




