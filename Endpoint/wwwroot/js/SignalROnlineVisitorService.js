var Connection = new signalR.HubConnectionBuilder()
    .withUrl("/chathub")
    .build();
Connection.start();