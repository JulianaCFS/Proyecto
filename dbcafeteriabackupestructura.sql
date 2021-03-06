--
-- PostgreSQL database dump
--

-- Dumped from database version 9.1.9
-- Dumped by pg_dump version 9.1.9
-- Started on 2013-06-04 20:53:11 CEST

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 178 (class 3079 OID 11721)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: -
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2015 (class 0 OID 0)
-- Dependencies: 178
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: -
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 177 (class 1259 OID 16683)
-- Dependencies: 5
-- Name: almuerzocompleto; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE almuerzocompleto (
    id bigint NOT NULL,
    precio double precision
);


--
-- TOC entry 175 (class 1259 OID 16672)
-- Dependencies: 5
-- Name: almuerzoparte; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE almuerzoparte (
    id bigint NOT NULL,
    precio double precision
);


--
-- TOC entry 174 (class 1259 OID 16659)
-- Dependencies: 5
-- Name: bebidascalientes; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE bebidascalientes (
    id bigint NOT NULL,
    nombre character varying(50),
    tamanyo character varying(20),
    precio double precision
);


--
-- TOC entry 173 (class 1259 OID 16654)
-- Dependencies: 5
-- Name: bebidasfrias; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE bebidasfrias (
    id bigint NOT NULL,
    nombre character varying(50),
    tamanyo character varying(15),
    precio double precision
);


--
-- TOC entry 161 (class 1259 OID 16564)
-- Dependencies: 5
-- Name: bocadillos; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE bocadillos (
    "idBocadillo" bigint NOT NULL,
    nombre character varying(50),
    descripcion character varying(100),
    precio double precision
);


--
-- TOC entry 162 (class 1259 OID 16567)
-- Dependencies: 5 161
-- Name: bocadillos_idBocadillo_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE "bocadillos_idBocadillo_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2016 (class 0 OID 0)
-- Dependencies: 162
-- Name: bocadillos_idBocadillo_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE "bocadillos_idBocadillo_seq" OWNED BY bocadillos."idBocadillo";


--
-- TOC entry 163 (class 1259 OID 16569)
-- Dependencies: 5
-- Name: bolleriadulce; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE bolleriadulce (
    id bigint NOT NULL,
    nombre character varying(50),
    tamano character varying(20),
    precio double precision
);


--
-- TOC entry 164 (class 1259 OID 16572)
-- Dependencies: 5 163
-- Name: bolleriaDulce_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE "bolleriaDulce_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2017 (class 0 OID 0)
-- Dependencies: 164
-- Name: bolleriaDulce_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE "bolleriaDulce_id_seq" OWNED BY bolleriadulce.id;


--
-- TOC entry 165 (class 1259 OID 16574)
-- Dependencies: 5
-- Name: bolleriasalada; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE bolleriasalada (
    id bigint NOT NULL,
    nombre character varying(50),
    tamano character varying(20),
    precio double precision
);


--
-- TOC entry 166 (class 1259 OID 16577)
-- Dependencies: 165 5
-- Name: bolleriaSalada_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE "bolleriaSalada_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2018 (class 0 OID 0)
-- Dependencies: 166
-- Name: bolleriaSalada_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE "bolleriaSalada_id_seq" OWNED BY bolleriasalada.id;


--
-- TOC entry 176 (class 1259 OID 16677)
-- Dependencies: 5
-- Name: desayunopopular; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE desayunopopular (
    id bigint NOT NULL,
    precio double precision
);


--
-- TOC entry 170 (class 1259 OID 16632)
-- Dependencies: 5
-- Name: mesas; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE mesas (
    idmesa bigint NOT NULL,
    maximo integer,
    disponible character varying(5)
);


--
-- TOC entry 169 (class 1259 OID 16630)
-- Dependencies: 170 5
-- Name: mesas_idmesa_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE mesas_idmesa_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2019 (class 0 OID 0)
-- Dependencies: 169
-- Name: mesas_idmesa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE mesas_idmesa_seq OWNED BY mesas.idmesa;


--
-- TOC entry 167 (class 1259 OID 16595)
-- Dependencies: 5
-- Name: pedidos; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE pedidos (
    id bigint NOT NULL,
    nombre character varying(255),
    tamano character varying(100),
    precio double precision,
    cantidad integer
);


--
-- TOC entry 168 (class 1259 OID 16598)
-- Dependencies: 5 167
-- Name: pedidos_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE pedidos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2020 (class 0 OID 0)
-- Dependencies: 168
-- Name: pedidos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE pedidos_id_seq OWNED BY pedidos.id;


--
-- TOC entry 172 (class 1259 OID 16640)
-- Dependencies: 5
-- Name: ticket; Type: TABLE; Schema: public; Owner: -; Tablespace: 
--

CREATE TABLE ticket (
    idticket bigint NOT NULL,
    identificador character varying,
    fk_idmesa bigint
);


--
-- TOC entry 171 (class 1259 OID 16638)
-- Dependencies: 172 5
-- Name: ticket_idticket_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE ticket_idticket_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2021 (class 0 OID 0)
-- Dependencies: 171
-- Name: ticket_idticket_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE ticket_idticket_seq OWNED BY ticket.idticket;


--
-- TOC entry 1979 (class 2604 OID 16601)
-- Dependencies: 162 161
-- Name: idBocadillo; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY bocadillos ALTER COLUMN "idBocadillo" SET DEFAULT nextval('"bocadillos_idBocadillo_seq"'::regclass);


--
-- TOC entry 1980 (class 2604 OID 16602)
-- Dependencies: 164 163
-- Name: id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY bolleriadulce ALTER COLUMN id SET DEFAULT nextval('"bolleriaDulce_id_seq"'::regclass);


--
-- TOC entry 1981 (class 2604 OID 16603)
-- Dependencies: 166 165
-- Name: id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY bolleriasalada ALTER COLUMN id SET DEFAULT nextval('"bolleriaSalada_id_seq"'::regclass);


--
-- TOC entry 1983 (class 2604 OID 16635)
-- Dependencies: 170 169 170
-- Name: idmesa; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY mesas ALTER COLUMN idmesa SET DEFAULT nextval('mesas_idmesa_seq'::regclass);


--
-- TOC entry 1982 (class 2604 OID 16606)
-- Dependencies: 168 167
-- Name: id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY pedidos ALTER COLUMN id SET DEFAULT nextval('pedidos_id_seq'::regclass);


--
-- TOC entry 1984 (class 2604 OID 16643)
-- Dependencies: 172 171 172
-- Name: idticket; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY ticket ALTER COLUMN idticket SET DEFAULT nextval('ticket_idticket_seq'::regclass);


--
-- TOC entry 2006 (class 2606 OID 16687)
-- Dependencies: 177 177 2009
-- Name: almuerzocompleto_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY almuerzocompleto
    ADD CONSTRAINT almuerzocompleto_pkey PRIMARY KEY (id);


--
-- TOC entry 2002 (class 2606 OID 16676)
-- Dependencies: 175 175 2009
-- Name: almuerzoparte_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY almuerzoparte
    ADD CONSTRAINT almuerzoparte_pkey PRIMARY KEY (id);


--
-- TOC entry 2000 (class 2606 OID 16663)
-- Dependencies: 174 174 2009
-- Name: bebidascalientes_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY bebidascalientes
    ADD CONSTRAINT bebidascalientes_pkey PRIMARY KEY (id);


--
-- TOC entry 1998 (class 2606 OID 16658)
-- Dependencies: 173 173 2009
-- Name: bebidasfrias_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY bebidasfrias
    ADD CONSTRAINT bebidasfrias_pkey PRIMARY KEY (id);


--
-- TOC entry 1986 (class 2606 OID 16610)
-- Dependencies: 161 161 2009
-- Name: bocadillos_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY bocadillos
    ADD CONSTRAINT bocadillos_pkey PRIMARY KEY ("idBocadillo");


--
-- TOC entry 1988 (class 2606 OID 16612)
-- Dependencies: 163 163 2009
-- Name: bolleriaDulce_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY bolleriadulce
    ADD CONSTRAINT "bolleriaDulce_pkey" PRIMARY KEY (id);


--
-- TOC entry 1990 (class 2606 OID 16614)
-- Dependencies: 165 165 2009
-- Name: bolleriaSalada_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY bolleriasalada
    ADD CONSTRAINT "bolleriaSalada_pkey" PRIMARY KEY (id);


--
-- TOC entry 2004 (class 2606 OID 16681)
-- Dependencies: 176 176 2009
-- Name: desayunopopular_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY desayunopopular
    ADD CONSTRAINT desayunopopular_pkey PRIMARY KEY (id);


--
-- TOC entry 1994 (class 2606 OID 16637)
-- Dependencies: 170 170 2009
-- Name: mesas_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY mesas
    ADD CONSTRAINT mesas_pkey PRIMARY KEY (idmesa);


--
-- TOC entry 1992 (class 2606 OID 16622)
-- Dependencies: 167 167 2009
-- Name: pedidos_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY pedidos
    ADD CONSTRAINT pedidos_pkey PRIMARY KEY (id);


--
-- TOC entry 1996 (class 2606 OID 16648)
-- Dependencies: 172 172 2009
-- Name: ticket_pkey; Type: CONSTRAINT; Schema: public; Owner: -; Tablespace: 
--

ALTER TABLE ONLY ticket
    ADD CONSTRAINT ticket_pkey PRIMARY KEY (idticket);


--
-- TOC entry 2007 (class 2606 OID 16649)
-- Dependencies: 1993 172 170 2009
-- Name: ticket_fk_idmesa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY ticket
    ADD CONSTRAINT ticket_fk_idmesa_fkey FOREIGN KEY (fk_idmesa) REFERENCES mesas(idmesa);


--
-- TOC entry 2014 (class 0 OID 0)
-- Dependencies: 5
-- Name: public; Type: ACL; Schema: -; Owner: -
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2013-06-04 20:53:12 CEST

--
-- PostgreSQL database dump complete
--

