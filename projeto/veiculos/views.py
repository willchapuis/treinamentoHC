from rest_framework.views import APIView
from django import forms
from django.shortcuts import render, redirect
from .models import *
from .form import *
from .serializers import *
from django.http import JsonResponse
from rest_framework.response import Response
from rest_framework import status

import datetime

# def home(request):
#     data = {}

#     data['now'] = datetime.datetime.now()
#     #html = "<html><body> Agora são %s. </body></html>" % now
    
#     return render(request, 'veiculos/home.html', data)

# def list_entrada(request):
#     data = {}

#     data['registros'] = Registro_Entrada.objects.all()

#     return render(request, 'veiculos/listagem_entrada.html', data)

# def list_saida(request):
#     data = {}

#     data['registros'] = Registro_Saida.objects.all()

#     return render(request, 'veiculos/listagem_saida.html', data)

# def create_registro_entrada(request):
#     form = RegistroEntradaForm(request.POST or None)

#     if form.is_valid():
#         form.save()
#         return redirect('url_listaEntradas')
    
#     return render(request, 'veiculos/form_registro_entrada.html', {'form': form})

# def create_registro_saida(request):
#     form = RegistroSaidaForm(request.POST or None)

#     if form.is_valid():
#         form.save()
#         return redirect('url_listaSaidas')

#     return render(request, 'veiculos/form_registro_saida.html', {'form': form})

# def update_entrada(request, pk):
#     data = {}
#     registro = Registro_Entrada.objects.get(pk=pk)
#     form = RegistroEntradaForm(request.POST or None, instance=registro)

#     if form.is_valid():
#         form.save()
#         return redirect('url_listaEntradas')

#     data['form'] = form
#     data['registro'] = registro
#     return render(request, 'veiculos/form_registro_entrada.html', data)

# def update_saida(request, pk):
#     data = {}
#     registro = Registro_Saida.objects.get(pk=pk)
#     form = RegistroSaidaForm(request.POST or None, instance=registro)

#     if form.is_valid():
#         form.save()
#         return redirect('url_listaSaidas')

#     data['form'] = form
#     data['registro'] = registro
#     return render(request, 'veiculos/form_registro_saida.html', data)

# def delete_entrada(request, pk):
#     registro = Registro_Entrada.objects.get(pk=pk)
#     registro.delete()
#     return redirect('url_listaEntradas')

# def delete_saida(request, pk):
#     registro = Registro_Saida.objects.get(pk=pk)
#     registro.delete()
#     return redirect('url_listaSaidas')

class ControleVeiculosEntradaListView(APIView):
    def get(self, request):
        try:
            lista = Registro_Entrada.objects.all()
            serial = ControleVeiculosEntradaListViewSerializer(lista, many=True)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosSaidaListView(APIView):
    def get(self, request):
        try:
            lista = Registro_Saida.objects.all()
            serial = ControleVeiculosSaidaListViewSerializer(lista, many=True)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosFaturaListView(APIView):
    def get(self, request):
        try:
            lista = Fatura.objects.all()
            serial = ControleVeiculosFaturaListViewSerializer(lista, many=True)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosCategoriaListView(APIView):
    def get(self, request):
        try:
            lista = Categoria.objects.all()
            serial = ControleVeiculosCategoriaListViewSerializer(lista, many=True)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosEntradaView(APIView):
    def get(self, request, id):
        try:
            registro = Registro_Entrada.objects.get(id=id)
            serial = ControleVeiculosEntradaViewSerializer(registro, many=False)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    def post(self, request):
        try:
            serial = ControleVeiculosEntradaViewSerializer(data=request.data)
            if serial.is_valid():
                serial.save()
                return Response(serial.data, status=status.HTTP_201_CREATED)
            else:
                return Response({'mensagem': str(serial.erros)}, status=status.HTTP_400_BAD_REQUEST)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    def put(self, request, id):
        try:
            registro = Registro_Entrada.objects.get(id=id)
            registro.placa = request.data["placa"]
            registro.hora_entrada = request.data["hora_entrada"]
            registro.save()
            return Response({'mensagem': 'Alterado com sucesso'}, status=status.HTTP_200_OK)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def delete(self, request, id):
        try:
            registro = Registro_Entrada.objects.get(id=id)
            registro.delete()
            return Response({'mensagem': 'Excluido com sucesso'}, status=status.HTTP_204_NO_CONTENT)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosSaidaView(APIView):
    def get(self, request, id):
        try:
            registro = Registro_Saida.objects.get(id=id)
            serial = ControleVeiculosSaidaViewSerializer(registro, many=False)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    def post(self, request):
        try:
            serial = ControleVeiculosEntradaViewSerializer(data=request.data)
            if serial.is_valid():
                serial.save()
                return Response(serial.data, status=status.HTTP_201_CREATED)
            else:
                return Response({'mensagem': str(serial.erros)}, status=status.HTTP_400_BAD_REQUEST)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
            
    def post(self, request):
        try:
            serial = ControleVeiculosSaidaViewSerializer(data=request.data)
            if serial.is_valid():
                serial.save()
                return Response(serial.data, status=status.HTTP_201_CREATED)
            else:
                return Response({'mensagem': str(serial.erros)}, status=status.HTTP_400_BAD_REQUEST)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    def put(self, request, id):
        try:
            registro = Registro_Saida.objects.get(id=id)
            registro.placa = request.data["placa"]
            registro.hora_entrada = request.data["hora_saida"]
            registro.save()
            return Response({'mensagem': 'Alterado com sucesso'}, status=status.HTTP_200_OK)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def delete(self, request, id):
        try:
            registro = Registro_Saida.objects.get(id=id)
            registro.delete()
            return Response({'mensagem': 'Excluido com sucesso'}, status=status.HTTP_204_NO_CONTENT)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

class ControleVeiculosFaturaView(APIView):
    def get(self, request, id):
        try:
            fatura = Fatura.objects.get(id=id)
            serial = ControleVeiculosFaturaViewSerializer(fatura, many=False)
            return Response(serial.data)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

    def post(self, request):
        try:
            serial = ControleVeiculosFaturaViewSerializer(data=request.data)
            if serial.is_valid():
                serial.save()
                return Response(serial.data, status=status.HTTP_201_CREATED)
            else:
                return Response({'mensagem': str(serial.errors)}, status=status.HTTP_400_BAD_REQUEST)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)

#     def put(self, request, id):
#         try:
#             fatura = Fatura.objects.get(id=id)
#             fatura.save()
#             return Response({'mensagem': 'Alterado com sucesso'}, status=status.HTTP_200_OK)
#         except Exception as e:
#             return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)
    
    def delete(self, request, id):
        try:
            fatura = Fatura.objects.get(id=id)
            fatura.delete()
            return Response({'mensagem': 'Excluido com sucesso'}, status=status.HTTP_204_NO_CONTENT)
        except Exception as e:
            return JsonResponse({'mensagem': str(e)}, status=status.HTTP_500_INTERNAL_SERVER_ERROR)