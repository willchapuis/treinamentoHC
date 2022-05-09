"""controle_veiculos URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/4.0/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path
from veiculos.views import *

urlpatterns = [
    path('admin/', admin.site.urls),
    # path('', home),
    # path('listar_entradas/', list_entrada, name='url_listaEntradas'),
    # path('listar_saidas/', list_saida, name='url_listaSaidas'),
    # path('cadastrar_entrada/', create_registro_entrada, name='url_novaEntrada'),
    # path('cadastrar_saida/', create_registro_saida, name='url_novaSaida'),
    # path('update_entrada/<int:pk>/', update_entrada, name='url_update_entrada'),
    # path('update_entrada/<int:pk>/', update_saida, name='url_update_saida'),
    # path('delete_entrada/<int:pk>/', delete_entrada, name='url_delete_entrada'),
    # path('delete_entrada/<int:pk>/', delete_saida, name='url_delete_saida'),
    path('api/ControleVeiculosEntradaListView', ControleVeiculosEntradaListView.as_view()),
    path('api/ControleVeiculosEntradaView', ControleVeiculosEntradaView.as_view()),
    path('api/ControleVeiculosEntradaView/<int:id>', ControleVeiculosEntradaView.as_view()),
    path('api/ControleVeiculosSaidaListView', ControleVeiculosSaidaListView.as_view()),
    path('api/ControleVeiculosSaidaView', ControleVeiculosSaidaView.as_view()),
    path('api/ControleVeiculosSaidaView/<int:id>', ControleVeiculosSaidaView.as_view()),
    path('api/ControleVeiculosFaturaListView', ControleVeiculosFaturaListView.as_view()),
    path('api/ControleVeiculosFaturaView', ControleVeiculosFaturaView.as_view()),
    path('api/ControleVeiculosFaturaView/<int:id>', ControleVeiculosFaturaView.as_view()),
    path('api/ControleVeiculosCategoriaListView/', ControleVeiculosCategoriaListView.as_view())
]
