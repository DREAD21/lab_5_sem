import math
import matplotlib.pyplot as plt
import pylab
import plotly.graph_objs as go
from matplotlib.widgets import Button, Slider
# Краснов Никита М80-303Б-19
# r = (a * math.cos(2 * fi)) / math.cos(fi)
# A, B - границы
# a - константа



def addPlot(graph_axes, a, A, B):

    d = 0.0001
    fi = A
    c = 0
    x_mass = []
    y_mass = []
    while fi < B:
        c += 1
        fi = fi + d
        r = (a * math.cos(2 * fi)) / math.cos(fi)
        x = r * math.cos(fi)
        y = r * math.sin(fi)
        x_mass.append(x)
        y_mass.append(y)
        # if c % 2 != 0:
        #     graph_axes.plot(x_mass, y_mass,'b')
        #     x_mass.clear()
        #     y_mass.clear()
    graph_axes.plot(x_mass, y_mass)
    pylab.show()


if __name__ == '__main__':
    def onButtonAddClicked(event):
        global slider_phi
        global slider_A
        global slider_B
        global graph_axes
        graph_axes.clear()
        graph_axes.set_xlabel(' Ось X    ',
                              fontsize=15,  # размер шрифта
                              color='green')

        graph_axes.set_ylabel(' Ось Y    ',
                              fontsize=15,  # размер шрифта
                              color='green')

        graph_axes.set_title('ρ = (a * math.cos(2 * fi)) / math.cos(fi)')
        graph_axes.axhline(0, color='green')  # x = 0
        graph_axes.axvline(0, color='green')  # y = 0
        graph_axes.grid()
        pylab.draw()
        addPlot(graph_axes, slider_phi.val, slider_A.val, slider_B.val)



    fig, graph_axes = pylab.subplots()
    graph_axes.grid()
    graph_axes.set_xlabel(' Ось X    ',
                          fontsize=15,  # размер шрифта
                          color='green')

    graph_axes.set_ylabel(' Ось Y    ',
                          fontsize=15,  # размер шрифта
                          color='green')

    graph_axes.set_title('ρ = (a * math.cos(2 * fi)) / math.cos(fi)')
    graph_axes.axhline(0, color='green')  # x = 0
    graph_axes.axvline(0, color='green')  # y = 0
    fig.subplots_adjust(left=0.07, right=0.95, top=0.95, bottom=0.4)

    axes_button_add = pylab.axes([0.7, 0.01, 0.25, 0.075])
    button_add = Button(axes_button_add, 'Построить')
    button_add.on_clicked(onButtonAddClicked)

    axes_slider_phi = pylab.axes([0.05, 0.25, 0.85, 0.04])
    slider_phi = Slider(axes_slider_phi,
                          label='a',
                          valmin=1,
                          valmax=10,
                          valinit=1,
                          valfmt='%1.2f')

    axes_slider_A = pylab.axes([0.05, 0.17, 0.85, 0.04])
    slider_A = Slider(axes_slider_A,
                       label='A',
                       valmin=-3.13,
                       valmax=3.13,
                       valinit=-1.5,
                       valfmt='%1.2f')
    axes_slider_B = pylab.axes([0.05, 0.09, 0.85, 0.04])
    slider_B = Slider(axes_slider_B,
                       label='B',
                       valmin=-3.13,
                       valmax=3.13,
                       valinit=1.5,
                       valfmt='%1.2f')

    pylab.show()