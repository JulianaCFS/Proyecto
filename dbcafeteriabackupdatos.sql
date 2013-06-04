--
-- PostgreSQL database dump
--

-- Dumped from database version 9.1.9
-- Dumped by pg_dump version 9.1.9
-- Started on 2013-06-04 20:52:31 CEST

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

SET search_path = public, pg_catalog;

--
-- TOC entry 2024 (class 0 OID 16683)
-- Dependencies: 177 2025
-- Data for Name: almuerzocompleto; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY almuerzocompleto (id, precio) FROM stdin;
1	5
\.


--
-- TOC entry 2022 (class 0 OID 16672)
-- Dependencies: 175 2025
-- Data for Name: almuerzoparte; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY almuerzoparte (id, precio) FROM stdin;
1	2.5
\.


--
-- TOC entry 2021 (class 0 OID 16659)
-- Dependencies: 174 2025
-- Data for Name: bebidascalientes; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY bebidascalientes (id, nombre, tamanyo, precio) FROM stdin;
1	cafe	cafe	0.900000000000000022
2	cortado	cortado	1
3	cafe con leche	cafe con leche	1.30000000000000004
4	bombon	bombon	1
5	carajillo coñac	carajillo coñac	1.30000000000000004
6	carajillo whisky	carajillo Whisky	1.39999999999999991
7	carajillo bayles	carajillo bayles	1.39999999999999991
\.


--
-- TOC entry 2020 (class 0 OID 16654)
-- Dependencies: 173 2025
-- Data for Name: bebidasfrias; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY bebidasfrias (id, nombre, tamanyo, precio) FROM stdin;
1	cocacola	bote	1.30000000000000004
2	cocacola light	bote	1.30000000000000004
3	cocacola zero	bote	1.30000000000000004
4	cocacola sin cafeina	bote	1.30000000000000004
5	fanta naranja	bote	1.30000000000000004
6	fanta limon	bote	1.30000000000000004
7	agua con gas	botella	1.10000000000000009
8	agua pequeña	botella	1
9	tonica	bote	1.30000000000000004
10	acuarios	bote	1.30000000000000004
11	nestea	bote	1.30000000000000004
12	bitter	bote	1.30000000000000004
13	amstel	tercio	1.30000000000000004
14	amstel	quinto	1.10000000000000009
15	heineken	tercio	1.60000000000000009
16	volldam	tercio	1.60000000000000009
17	calsberg	tercio	1.60000000000000009
\.


--
-- TOC entry 2008 (class 0 OID 16564)
-- Dependencies: 161 2025
-- Data for Name: bocadillos; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY bocadillos ("idBocadillo", nombre, descripcion, precio) FROM stdin;
1	catalana	jamon y tomate rallado	3
2	atún	atún,tomate y olivas	3
3	blanco y negro	longaniza y morcilla	3
4	tortilla de patata	tortilla de patata casera	3
\.


--
-- TOC entry 2029 (class 0 OID 0)
-- Dependencies: 162
-- Name: bocadillos_idBocadillo_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('"bocadillos_idBocadillo_seq"', 1, false);


--
-- TOC entry 2030 (class 0 OID 0)
-- Dependencies: 164
-- Name: bolleriaDulce_id_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('"bolleriaDulce_id_seq"', 1, false);


--
-- TOC entry 2031 (class 0 OID 0)
-- Dependencies: 166
-- Name: bolleriaSalada_id_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('"bolleriaSalada_id_seq"', 1, false);


--
-- TOC entry 2010 (class 0 OID 16569)
-- Dependencies: 163 2025
-- Data for Name: bolleriadulce; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY bolleriadulce (id, nombre, tamano, precio) FROM stdin;
1	croissant 	pequeno	0.5
2	croissant 	grande	1.10000000000000009
3	croissant choco 	pequeno	0.599999999999999978
4	susu	pequeno	0.800000000000000044
5	magdalena normal	pequena	0.5
6	donouts blanco	normal	0.900000000000000022
7	donouts choco	normal	1
\.


--
-- TOC entry 2012 (class 0 OID 16574)
-- Dependencies: 165 2025
-- Data for Name: bolleriasalada; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY bolleriasalada (id, nombre, tamano, precio) FROM stdin;
1	tostada tomate	normal	1.10000000000000009
2	tostada aceite	normal	0.900000000000000022
3	croissant vegetal	grande	2
\.


--
-- TOC entry 2023 (class 0 OID 16677)
-- Dependencies: 176 2025
-- Data for Name: desayunopopular; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY desayunopopular (id, precio) FROM stdin;
1	2
\.


--
-- TOC entry 2017 (class 0 OID 16632)
-- Dependencies: 170 2025
-- Data for Name: mesas; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY mesas (idmesa, maximo, disponible) FROM stdin;
7	4	no
8	4	no
9	4	no
10	4	no
1	4	no
2	4	no
3	4	no
4	4	no
5	4	no
6	4	no
\.


--
-- TOC entry 2032 (class 0 OID 0)
-- Dependencies: 169
-- Name: mesas_idmesa_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('mesas_idmesa_seq', 10, true);


--
-- TOC entry 2014 (class 0 OID 16595)
-- Dependencies: 167 2025
-- Data for Name: pedidos; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY pedidos (id, nombre, tamano, precio, cantidad) FROM stdin;
\.


--
-- TOC entry 2033 (class 0 OID 0)
-- Dependencies: 168
-- Name: pedidos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('pedidos_id_seq', 28, true);


--
-- TOC entry 2019 (class 0 OID 16640)
-- Dependencies: 172 2017 2025
-- Data for Name: ticket; Type: TABLE DATA; Schema: public; Owner: dbcafeteria
--

COPY ticket (idticket, identificador, fk_idmesa) FROM stdin;
\.


--
-- TOC entry 2034 (class 0 OID 0)
-- Dependencies: 171
-- Name: ticket_idticket_seq; Type: SEQUENCE SET; Schema: public; Owner: dbcafeteria
--

SELECT pg_catalog.setval('ticket_idticket_seq', 29, true);


-- Completed on 2013-06-04 20:52:31 CEST

--
-- PostgreSQL database dump complete
--

