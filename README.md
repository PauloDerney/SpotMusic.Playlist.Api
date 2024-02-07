# SpotMusic.Playlist.Api

Bem-vindo à API de Playlist da SpotMusic, a plataforma que permite a gestão eficiente e personalizada de playlists. Desenvolvida pela SpotMusic, esta API oferece funcionalidades robustas para criação, reprodução de playlists, atendendo às necessidades exclusivas da SpotyMusic.

## Sumário

- [Recursos](#recursos)
- [Autenticação](#autenticação)
- [Endpoints](#endpoints)
- [Exemplos de Uso](#exemplos-de-uso)
- [Contribuições](#contribuições)

## Recursos

- **Criação de Playlist:** Crie playlists personalizadas para diferentes equipes ou eventos.
- **Reprodução Contínua:** Desfrute de reprodução contínua de playlists durante as horas de trabalho.

## Autenticação

A autenticação na SpotMusic API é feita por meio de chave de API. Ao solicitar acesso à API, você receberá uma chave única que deve ser incluída no cabeçalho de todas as solicitações.

```http
Headers:
  Authorization: Bearer SUA_CHAVE_DE_API
```

## Endpoints

### 1. Criação de Playlist

- **Endpoint:** `POST /playlists`
- **Parâmetros:**
  - `nome` (string): Nome da playlist.
  - `descricao` (string): Descrição da playlist.

### 2. Adição de Música à Playlist

- **Endpoint:** `POST /playlists/{id}/musics/{idMusic}`
- **Parâmetros:**
  - `id` (string): ID da playlist a ser gerenciada.
  - `idMusic` (string): ID da música a ser adicionada.

### 3. Remoção de Música da Playlist

- **Endpoint:** `DELETE /playlists/{id}/remover`
- **Parâmetros:**
  - `musica_id` (string): ID da música a ser removida.

### 4. Listagem de Playlists

- **Endpoint:** `GET /playlists`

### 5. Reprodução de Playlist

- **Endpoint:** `POST /playlists/{id}/play`

## Exemplos de Uso

### Criação de Playlist

```http
POST /playlists
{
  "nome": "Playlist da Equipe de Desenvolvimento",
  "descricao": "Melhores músicas para impulsionar a criatividade"
}
```

### Adição de Música à Playlist

```http
POST /playlists/123/musics/456
```

### Remoção de Música da Playlist

```http
DELETE /playlists/123/musics/324
```

### Listagem de Playlists

```http
GET /playlists
```

### Reprodução de Playlist

```http
POST /playlists/123/play
```

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas, propor melhorias ou enviar solicitações de pull.
